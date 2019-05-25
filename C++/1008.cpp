#include<iostream>
#include<iomanip>

using namespace std; 

int main() { 
	
	int num, ora;
	double sa, sal;
	
	cin >> num >> ora >> sal; 
	
	sa = ora * sal;
	
	cout << fixed << setprecision(2);
	
	cout << "NUMBER = " << num <<"\nSALARY = U$ " << sa<< endl;
	

return 0;
}
