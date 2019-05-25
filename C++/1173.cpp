#include<iostream>

using namespace std; 

int main() {
	
	int n, vet[10]; 
	
	cin >> n; 
	
	cout << "N[" << 0 << "] = " << n << endl;
	
	int x = n * 2;
	
	for(int i = 1; i < 10; i ++){
		cout << "N[" << i << "] = " << x << endl;
		x = x * 2;
	}
}
