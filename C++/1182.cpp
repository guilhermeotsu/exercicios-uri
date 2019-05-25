#include <iostream>
#include <stdio.h>

int main(){
    int n;
    char c;
    double m[12][12];
    double s = 0.0;
    
    std::cin >> n;
    std::cin >> c;    
    
    for(int i = 0; i < 12; i++){
            for(int j = 0; j < 12; j++){
                   std::cin >> m[i][j];
                   if(j == n){
                        s += m[i][j];
                   }
            }
   }
   
   if(c == 'S')
         printf("%.1f\n", s);
    else
         printf("%.1f\n", s/12.0);
    return 0;
}
