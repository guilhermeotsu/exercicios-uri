#include <iostream>
#include<iomanip>

using namespace std;
int main()
{
	int T, V; 
	float QntLit; 
	
	cin >> T >> V; 
	
	QntLit = (T * V) / 12.0; 
		
		cout << fixed << setprecision(3);
	cout << QntLit << endl;
	
  return 0;
}
