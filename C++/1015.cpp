#include<math.h>
#include<iostream>
#include<iomanip>

using namespace std; 


int main (){
	
	double x1, x2, y1, y2, dist; 
	
	cin >> x1 >> y1 >>  x2 >> y2;
	
	dist = sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
	cout << fixed << setprecision(4);
	cout << dist << endl;
}
