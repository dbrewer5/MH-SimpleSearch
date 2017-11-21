#pragma once

#include <string>
#include <vector>
#include <memory>
#include <unordered_map>

class Skill {
private:
	std::string _skill_name;
	std::string _skill_type_name;
	int _activation_points;
	friend std::ostream& operator<< (std::ostream& stream, const Skill& skill);
	void print(std::ostream& stream) const;

public:
	Skill(const std::string& skill_name, const std::string& skill_type_name, int activation_points);
	const std::string& getSkillName() const;
	const std::string& getSkillTypeName() const;
	const int getActivationPoints() const;
	const bool isActivated(int points) const;
};

typedef std::vector<std::shared_ptr<Skill>> SkillVector;
typedef std::unordered_multimap<std::string, std::shared_ptr<Skill>> SkillMap;

std::unique_ptr<SkillVector> loadSkillsFromFileToVector(const std::string& path);

std::unique_ptr<SkillMap> convertSkillVectorToSkillMap(const SkillVector& skills);