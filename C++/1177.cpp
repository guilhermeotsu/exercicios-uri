#include<iostream>

using namespace std; 

int main(){
	
	int t, vet[6];
	
	cin >> t; 
	
	for(int i = 0; i <= 6; i++){ 
		for(int j = 0; j < t; j++){
			vet[i] = j;
			cout << "N[" << i << "] = " << j << endl; 
		}
}
}
