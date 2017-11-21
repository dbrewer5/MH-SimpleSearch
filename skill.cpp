#include "skill.h"
#include <fstream>
#include <sstream>
#include <iostream>

Skill::Skill(const std::string& skill_name, const std::string& skill_type_name, int activation_points)
	: _skill_name(skill_name), _skill_type_name(skill_type_name), _activation_points(activation_points) {}

const std::string& Skill::getSkillName() const {
	return _skill_name;
}

const std::string& Skill::getSkillTypeName() const {
	return _skill_type_name;
}

const int Skill::getActivationPoints() const {
	return _activation_points;
}

const bool Skill::isActivated(int points) const {
	if ((points < 0 && _activation_points < 0 && points < _activation_points) ||
		(points > 0 && _activation_points > 0 && points > _activation_points)) {
		return true;
	}
	return false;
}

std::ostream& operator<< (std::ostream& stream, const Skill& skill) {
	skill.print(stream);
	return stream;
}

void Skill::print(std::ostream& stream) const {
	stream << std::showpos << _skill_type_name << " " << _activation_points << ": " << _skill_name;
}

std::unique_ptr<SkillVector> loadSkillsFromFileToVector(const std::string& path) {
	std::unique_ptr<SkillVector> failure(nullptr);

	std::ifstream file(path);
	if (!file) {
		return failure;
	}

	std::unique_ptr<SkillVector> result(new SkillVector);

	for (std::string line; std::getline(file, line); ) {
		if (line.at(0) != '#') {
			std::vector<std::string> fields;
			std::stringstream stream(line);
			for (std::string field; getline(stream, field, '|'); ) {
				fields.push_back(field);
			}

			std::string skill_name = fields.at(0);
			std::string skill_type_name = fields.at(1);
			int activation_points = stoi(fields.at(2));

			result->push_back(std::shared_ptr<Skill>(new Skill(skill_name, skill_type_name, activation_points)));
		}
	}

	file.close();
	return result;
}

std::unique_ptr<SkillMap> convertSkillVectorToSkillMap(const SkillVector& skills) {
	std::unique_ptr<SkillMap> result(new SkillMap);
	for (size_t i = 0; i < skills.size(); i++) {
		result->insert(std::make_pair(skills.at(i)->getSkillTypeName(), skills.at(i)));
	}
	return result;
}