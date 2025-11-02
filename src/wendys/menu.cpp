#include <iostream>
#include <string>
#include <Windows.h>
using namespace std;


string combos();
string side();
string burgers();
int main()
{
	int a, b, c, d, e, f, g, h, i;
	char again;

	do
	{
		
		cout << "Enter you choice: " << endl;
		cout << "(1)combos	(2)burgers	(3)chicken" << endl;
		cin  >> a;
		if (a = 1)
		{
			combos();
			cout << endl;
			side();
		}
		cout << endl;
		cout << "Do you want another order? (Y/N)";
		cin  >> again;
	} while ((again == 'Y') || (again == 'y'));
	system("pause");
	return 0;
}
string combos()
{
	
	int burger;
	int side;

	cout << "(1)Single	(2)Double: " << endl;
	cin  >> burger;
	if (burger == 1)
	{
		int size;
		string burger = "single";
		cout << "Choose a side: " << endl;
		cout << "(1)fry	(2)potato	(3)salad" << endl;
		cin >> side;
		if (side == 1)
			cout << "small fry";
		else if (side == 2)
			cout << "medium fry";
		else if (side == 3)
			cout << "large fry";

		cout << burger;
		cout << side;
		return burger;
	}
}
/*string side()
{
	int side;
	cout << "Choose a side: " << endl;
	cout << "(1)fry	(2)potato	(3)salad" << endl;
	cin >> side;
	if (side == 1)
	{
		string side;
		int size;
		cout << "(1)small	(2)medium	(3)large" << endl;
		cin >> size;
		if (size == 1)
			cout << "small fry";
		else if (size == 2)
			cout << "medium fry";
		else if (size == 3)
			cout << "large fry";
		return side;
	}
	
}*/