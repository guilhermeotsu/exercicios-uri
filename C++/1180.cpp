#include<iostream>

using namespace std; 

int main() {
	int x, men, pos;
	
	cin >> x; 
	
	int vet[x]; 
	
	for(int i = 0; i < x; i ++) {
		cin >> vet[i]; 
		if(men > vet[i]) {
			men = vet[i];
			pos = i;
		}
	}
	cout << "Menor valor: " << men << endl
		 << "Posicao: " << pos << endl;
}


