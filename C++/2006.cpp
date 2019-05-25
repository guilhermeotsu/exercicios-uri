#include<iostream>

using namespace std;

int main()  { 
	int x, y, n = 0; 
	
	cin >> x; 
	
	for(int i = 0; i <= 4; i++) { 
		cin >> y; 
		if(y == x){ 
			n++;
		}
	}
	
	cout << n << endl;
}
