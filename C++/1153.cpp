#include<iostream>

using namespace std;

int main(){
	int n, f; 
	
	cin >> n;
	
	f = 1;
	
	for(int i = 0; i < (n - 1); i++){
		f *= (n - i);
	}
	cout << f <<endl;
}
