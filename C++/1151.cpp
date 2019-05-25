#include<iostream>

using namespace std;

int main(){
	
	int n, f[46];
	
	f[0] = 0;
	f[1] = 1;
	
	cin >> n;
	
	cout << f[0] << " " <<f[1] <<" ";
	
	for(int i = 2; i < n; i++){
		f[i] = f[i-1] + f[i-2];
		if(i == (n-1))
			cout << f[i];
		else 
			cout <<f[i] << " ";			
	}
	cout <<endl; 
}
