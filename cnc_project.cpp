#include "pch.h"
#include <iostream>
#include <fstream>
#include <cstdlib>
#include <string>
#include <windows.h>
#include "func.h"

using namespace std;
int main()
{
	fstream file;

	string line, x, y, z, fileName;
	float X, Y, Z;


	cout << "Wellcom in MasterCNC program" << endl;
	cout << "\n";
	cout << "Name of file: " << endl;
	cin >> fileName;
	file.open(fileName, ios::in);
	if (file.good() == false)
	{
		cout << "Nie ma takiego pliku" << endl;

	}
	if (!(checkLine(fileName)))
	{
		cout << "Unexpected char in Gcode";
		return 0;
	}

	while (getline(file, line))
	{

		if (line == "G0")
		{
			cout << "Koniec Programu";
			return 0;
		}

		cout << line << endl;
		cout << " " << endl;
		x = getAxis(line, 'X');
		y = getAxis(line, 'Y');
		z = getAxis(line, 'Z');
		X = getValue(x);
		Y = getValue(y);
		Z = getValue(z);

		Sleep(1000);
		cout << "X:" << X << endl;
		Sleep(1000);
		cout << "Y:" << Y << endl;
		Sleep(1000);
		cout << "Z:" << Z << endl;
		cout << " " << endl;
		Sleep(1000);
	}
	return 0;
}
