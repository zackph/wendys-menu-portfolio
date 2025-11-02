#include <iostream>
#include <string>
using namespace std;

class Combos
{
	private:
		int burger;
		int side;
		int drink;
	public:
		void setBurger(int);
		void setSide(int);
		void setDrink(int);
		int getBurger();

};

void Combos::setBurger(int b, int s, int d)
{
	if (b = 1)
		string burger = "single";
	if (b = 2)
		string burger = "double";
}

int Combos::getBurger()
{
	return burger;
}

int main()
{
	Combos one;

	cout << "Enter your choice:" << endl;
	cout << "(1)Single	(2)Double " << endl;
	cin << one.setBurger;
	cout << "Your order is:" << endl;
	cout << one.getBurger() << endl;

	system("pause");
	return 0;
}