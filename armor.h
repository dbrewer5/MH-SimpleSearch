#pragma once

#include "skill.h"

struct ArmorSkillPair {
	std::string skill_type_name;
	int points;
};

class Armor {
private:
	std::string _armor_name;
	std::string _armor_type_name;
	std::vector<ArmorSkillPair> _armor_skills;
	friend std::ostream& operator<< (std::ostream& stream, const Armor& armor);
	void print(std::ostream& stream) const;

public:
	Armor(const std::string& armor_name, const std::string armor_type_name, const std::vector<ArmorSkillPair> armor_skills);
	const std::string& getArmorName() const;
	const std::string& getArmorTypeName() const;
	const std::vector<ArmorSkillPair>& getArmorSkills() const;
};

typedef std::vector<std::shared_ptr<Armor>> ArmorVector;

std::unique_ptr<ArmorVector> loadArmorFromFileToVector(const std::string& path);