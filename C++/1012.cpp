#include<iostream> 
#include<iomanip>

using namespace std; 

int main(){ 

	double a, b, c; 
	
	cin >> a >> b >> c; 
	
	cout << fixed << setprecision(3); 
	
	cout << "TRIANGULO: " << a * c / 2
		 << "\nCIRCULO: " << 3.14159 * c * c 
		 << "\nTRAPEZIO: " << (a + b) * c / 2
		 << "\nQUADRADO: " << b * b
		 << "\nRETANGULO: " << a * b  << endl;
}
