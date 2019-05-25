
#include <iostream>
#include<iomanip>

using namespace std; 

int main()
{
	int x; 
	double y, z; 

	cin >> x >> y; 
	
	z = x / y;
	cout << fixed << setprecision(3);
	cout << z << " km/l" << endl;
}


