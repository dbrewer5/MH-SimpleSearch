#include "armor.h"
#include <fstream>
#include <sstream>

Armor::Armor(const std::string& armor_name, const std::string armor_type_name, const std::vector<ArmorSkillPair> armor_skills)
	: _armor_name(armor_name), _armor_type_name(armor_type_name), _armor_skills(armor_skills) {}

const std::string& Armor::getArmorName() const {
	return _armor_name;
}

const std::string& Armor::getArmorTypeName() const {
	return _armor_type_name;
}

const std::vector<ArmorSkillPair>& Armor::getArmorSkills() const {
	return _armor_skills;
}

std::ostream& operator<< (std::ostream& stream, const Armor& armor) {
	armor.print(stream);
	return stream;
}

void Armor::print(std::ostream& stream) const {
	stream << _armor_name << std::endl;
	for (size_t i = 0; i < _armor_skills.size(); i++) {
		stream << "\t" << std::showpos << _armor_skills.at(i).skill_type_name << " " << _armor_skills.at(i).points << std::endl;
	}
}

std::unique_ptr<ArmorVector> loadArmorFromFileToVector(const std::string& path) {
	std::unique_ptr<ArmorVector> failure(nullptr);

	std::ifstream file(path);
	if (!file) {
		return failure;
	}

	std::unique_ptr<ArmorVector> result(new ArmorVector);

	for (std::string line; std::getline(file, line); ) {
		if (line.at(0) != '#') {
			std::vector<std::string> fields;
			std::stringstream stream(line);
			for (std::string field; getline(stream, field, '|'); ) {
				fields.push_back(field);
			}

			std::string armor_name = fields.at(0);
			std::string armor_type_name = fields.at(1);
			std::vector<ArmorSkillPair> armor_skills;
			for (size_t i = 2; i < fields.size(); i += 2) {
				ArmorSkillPair armor_skill_pair;
				armor_skill_pair.skill_type_name = fields.at(i);
				armor_skill_pair.points = stoi(fields.at(i + 1));
				armor_skills.push_back(armor_skill_pair);
			}

			result->push_back(std::shared_ptr<Armor>(new Armor(armor_name, armor_type_name, armor_skills)));
		}
	}

	file.close();
	return result;
}