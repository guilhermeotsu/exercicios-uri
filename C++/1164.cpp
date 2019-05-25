#include<iostream>

using namespace std;

int main(){
	int n, sum = 0;
	
	cin >> n;
	
	for(int i = 1; i <= n; i++){
		cin >> n;
		if (n % i  == 0){
			sum += i;
			if(sum == n) {
				cout << n << " eh perfeito" <<endl;
			} else if (sum != n){
				cout << n << " nao eh perfeito" <<endl;
			}
		}
	}
	
}
