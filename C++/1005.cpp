#include<iostream> 
#include<iomanip>

using namespace std; 

int main(){ 
	
	double a, b, c; 
	
	cin >> a >> b; 
	
	c = (a * 3.5 + b * 7.5) / 11.0;
	
	cout << fixed << setprecision(5);
	cout <<  "MEDIA = " << c << endl;

return 0;
}
