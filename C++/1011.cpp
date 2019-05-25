#include<iostream> 
#include<iomanip>

using namespace std; 

int main(){ 

	int r; 
	
	cin >> r ;
	
	cout << fixed << setprecision(3); 
	
	cout << "VOLUME = " << (4.0 / 3) * 3.14159 * r * r * r << endl; 

}
