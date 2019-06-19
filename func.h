#pragma once
#include "pch.h"
#include <iostream>
#include <fstream>
#include <string>
#include<sstream>
using namespace std;

string getAxis(string line, char a)// getting x,y,z value in string format from line;
{
	int X = 0, Y = 0, Z = 0;
	string x;

	int Size = line.size();
	for (int i = 0; i < Size; i++)
	{

		if (line[i] == 'X')
		{
			X = 1;
			Y = 0;
			Z = 0;
		}
		if (line[i] == 'Y')
		{
			X = 0;
			Y = 1;
			Z = 0;
		}
		if (line[i] == 'Z')
		{
			X = 0;
			Y = 0;
			Z = 1;
		}
		switch (a) {
		case 'X':
			if (X == 1 && line[i] != a)
				x += line[i];
			break;
		case 'Y':
			if (Y == 1 && line[i] != a)
				x += line[i];
			break;
		case 'Z':
			if (Z == 1 && line[i] != a)
				x += line[i];
			break;



		}
	}


	return x;

}

float getValue(string value)// conversion from string to float
{
	if (value > "9999.9")
		return 9999;
	if (value == "")
		return 9999;

	char X[8];

	float ValueX = 0;

	for (int i = 0;i < value.size();i++)
	{
		X[i] = value[i];
	}

	ValueX = atof(X);
	return ValueX;
}

bool checkLine(string A)// check for mistake in program (correct is X0.0Y0.0Z0.0;) 
{
	fstream file;
	string line;
	file.open(A, ios::in);
	if (file.good() == false)
	{
		cout << "Nie ma takiego pliku" << endl;

	}
	while (getline(file, line))
	{
		for (int i = 0;i < line.size();i++)
			if (line[i] != 'X' && line[i] != 'Y' && line[i] != 'Z' && line[i] != ';'
				&& line[i] != '.' && line[i] != '-'
				&& line[i] != '0'
				&& line[i] != '1'
				&& line[i] != '2'
				&& line[i] != '3'
				&& line[i] != '4'
				&& line[i] != '5'
				&& line[i] != '6'
				&& line[i] != '7'
				&& line[i] != '8'
				&& line[i] != '9')

				return false;

	}

	return true;

}
