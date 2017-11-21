#pragma once

#include "armor.h"

class ArmorSet {
private:
	std::string _set_name;
	std::shared_ptr<Armor> _head;
	std::shared_ptr<Armor> _body;
	std::shared_ptr<Armor> _arms;
	std::shared_ptr<Armor> _waist;
	std::shared_ptr<Armor> _legs;
	friend std::ostream& operator<< (std::ostream& stream, const ArmorSet& armor_set);
	void print(std::ostream& stream) const;

public:
	ArmorSet(const std::string& set_name,
		std::shared_ptr<Armor> head,
		const std::shared_ptr<Armor> body,
		const std::shared_ptr<Armor> arms,
		const std::shared_ptr<Armor> waist,
		const std::shared_ptr<Armor> legs);
};