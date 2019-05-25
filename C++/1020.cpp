#include<iostream>

using namespace std;

int main() 
{ 
	int Idd, A, M, D; 
	
	cin >> Idd;
	
	A = Idd / 365; 
	M = Idd % 365 / 30; 
	D = Idd % 365 % 30;

	cout << A << " ano(s)"<< endl
	   	 << M << " mes(es)"<< endl
		 << D << " dia(s)" << endl;

}
