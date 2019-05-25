#include<iostream>

using namespace std;

int main() {
	int m, n, sum = 0, sum1 = 0;
	
	cin >> m >> n;
	
	while(m > 0 && n > 0){ 
		if (m > n) { 
			for(int i = n; i <= m; i++){ 
				sum += i;
				cout << i << " ";
				if(i == m){
				 	cout <<  "Sum=" << sum <<endl;
				 	sum =0;
				}					
			}
		} else 
			for(int j = m; j <= n; j++) { 
				sum1 += j;
				cout << j << " ";
				if(j == n){
				 	cout <<  "Sum=" << sum1 <<endl;
				 	sum1 = 0;
				}
			}
		cin >> m >> n;
	}
}
