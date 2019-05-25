#include<iostream> 
#include<iomanip>

using namespace std; 

int main(){ 
	
	double a, b, c, d; 
	
	cin >> a >> b >> d; 
	
	c = (a * 2 + b * 3 + d * 5) / 10.0;
	
	cout << fixed << setprecision(1);
	cout <<  "MEDIA = " << c << endl;

return 0;
}
