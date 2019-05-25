#include<iostream> 
#include<iomanip>

using namespace std; 

int main(){ 
	int p1, np1, p2, np2;
	double vl1, vl2, tot;
	
	cin >> p1 >> np1 >> vl1;
	cin >> p2 >> np2 >> vl2;
	
	tot = (np1 * vl1) + (np2 * vl2);
	

	cout << "VALOR A PAGAR: R$ " << fixed << setprecision(2) << tot << endl; 
}
