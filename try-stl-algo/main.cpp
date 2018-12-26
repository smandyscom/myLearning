#include<algorithm>
#include<array>
#include<math.h>
#include<iostream>

using namespace std;

typedef struct myVector
{
    float x;
    float y;
} MYVECTOR;

bool thePredicate(MYVECTOR vector)
{
    return sqrt(pow(vector.x,2)+pow(vector.y,2)) == 1;
}
void theAction(MYVECTOR vector)
{
    printf("%f,%f\n",vector.x,vector.y);
}
float theUnaryOperator(MYVECTOR vector)
{
    return sqrt(pow(vector.x,2)+pow(vector.y,2));
}
int main(int argc, char const *argv[])
{
    std::array<MYVECTOR,5> v;
    std::array<float,5> lengths;

    v[0].x = 2; v[0].y = 3;
    v[1].x = 4; v[1].y = 5;
    v[2].x = 6; v[2].y = 7;
    v[3].x = 0; v[3].y = 1;

    std::array<MYVECTOR,5>::iterator it =  std::find_if(v.begin(),v.end(),thePredicate);
    theAction(*it);

    std::for_each(v.begin(),v.end(),theAction);
    std::transform(v.begin(),v.end(),lengths.begin(),theUnaryOperator);

    return 0;
}

