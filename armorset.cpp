#include "armorset.h"

ArmorSet::ArmorSet(const std::string& set_name,
	const std::shared_ptr<Armor> head,
	const std::shared_ptr<Armor> body,
	const std::shared_ptr<Armor> arms,
	const std::shared_ptr<Armor> waist,
	const std::shared_ptr<Armor> legs)
	: _head(head), _body(body), _arms(arms), _waist(waist), _legs(legs) {};

std::ostream& operator<< (std::ostream& stream, const ArmorSet& armor_set) {
	armor_set.print(stream);
	return stream;
}

void ArmorSet::print(std::ostream& stream) const {
	stream << _set_name << std::endl;
	if (_head != nullptr) {
		stream << "\t" << _head->getArmorName() << std::endl;
	}
	if (_body != nullptr) {
		stream << "\t" << _body->getArmorName() << std::endl;
	}
	if (_arms != nullptr) {
		stream << "\t" << _arms->getArmorName() << std::endl;
	}
	if (_waist != nullptr) {
		stream << "\t" << _waist->getArmorName() << std::endl;
	}
	if (_legs != nullptr) {
		stream << "\t" << _legs->getArmorName() << std::endl;
	}
}