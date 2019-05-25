#include<iostream>
#include<iomanip>
#include<string>

using namespace std; 

int main() { 
	
	string nome; 
	double s, nven, tot;
	
	cin >> nome >> s >> nven; 
	
	tot = s + nven * 0.15;
	
	cout << fixed << setprecision(2);	
	cout << "TOTAL = R$ " << tot << endl;
	
}
