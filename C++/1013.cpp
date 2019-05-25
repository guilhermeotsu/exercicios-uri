#include<iostream> 
#include<math.h>

using namespace std; 

int main(){ 

	int a, c, b,d; 
	
	cin >> a >> b >> c; 
	
	d = (a + b + abs(a - b)) / 2;
	d = (d + c + abs(d - c)) / 2;
	
	cout << d << " eh o maior" << endl;
}
