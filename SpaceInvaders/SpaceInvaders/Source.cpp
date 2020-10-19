#include <iostream>
#include<Windows.h>
#include<time.h>
#include"Map.h"
#include"game.h"
#include"Maps.h"


int main()
{
	

	system("color 0b");
	
	while (game==false)
	{
		srand(time(0));
		system("cls");
		for (int y = 0; y < 22; y++)
		{
			std::cout << Kart[y] << std::endl;
			
		}

		std::cout << "\n\tSize:" << your << "/" << comp << std::endl;

		for (int y = 0; y < 22; y++)
		{
			for (int x = 0; x < 22; x++)
			{
				switch (Kart[y][x])
				{
					
				case 'W':
					

					if (GetAsyncKeyState(VK_LEFT) != 0)
					{
						int  newX = x - 1;
						switch (Kart[y][newX])
						{
						case ' ':
							Kart[y][x] = ' ';
							x - 1;
							Kart[y][newX] = 'W';
							break;
						}

					}

					if (GetAsyncKeyState(VK_RIGHT) != 0)
					{
						int newX = x + 1;
						switch (Kart[y][newX])
						{
						case ' ':
							Kart[y][x] = ' ';
							x++;
							Kart[y][newX] = 'W';
							break;
						}
					}

					if (GetAsyncKeyState(VK_SPACE) != 0)
					{
						y--;
						Kart[y][x] = '^';
						
					}
					
					break;
				case '^':
					
					Kart[y][x] = ' ';
				    y--;
					
					
					if (Kart[y][x] != '#' && Kart[y][x] != '@')
					{
						Kart[y][x] = '^';
						
						
					}
					 else if (Kart[y][x] == '@')
					{
						
						Kart[y][x] = '^';
						comp -= 10;
						
					 
					}

					break;
				 case '@':
					 
					 randnull = rand() % 10 + 1;
					 
					 if (randnull == 1)
					 {
						 
						 
						 y++;
						 Kart[y][x] = '*';
						 
						 
					 }
					 break;

				 case '*':
					 Kart[y][x] = ' ';
					 y++;
					 
					 if (Kart[y][x] != '#' && Kart[y][x] != 'W')
					 {
						 Kart[y][x] = '*';
						 
					 }
					 else if (Kart[y][x] == 'W')
					 {
						 your -= 20;



					 }
					 break;

					
				}
				
				

			
			}
		}
		if (your <= 0)
		{
			game = true;

		}
		
		if (comp<=0)
			while (game_a == false)
			{
				srand(time(0));
				system("cls");
				for (int y = 0; y < 22; y++)
				{
					std::cout << Kart1[y] << std::endl;

				}
				std::cout << "\n\tSize:" << your_a << "/" << comp_a << std::endl;

				for (int y = 0; y < 22; y++)
				{
					for (int x = 0; x < 22; x++)
					{
						switch (Kart1[y][x])
						{

						case 'W':


							if (GetAsyncKeyState(VK_LEFT) != 0)
							{
								int  newX = x - 1;
								switch (Kart1[y][newX])
								{
								case ' ':
									Kart1[y][x] = ' ';
									x - 1;
									Kart1[y][newX] = 'W';
									break;
								}

							}

							if (GetAsyncKeyState(VK_RIGHT) != 0)
							{
								int newX = x + 1;
								switch (Kart1[y][newX])
								{
								case ' ':
									Kart1[y][x] = ' ';
									x++;
									Kart1[y][newX] = 'W';
									break;
								}
							}

							if (GetAsyncKeyState(VK_SPACE) != 0)
							{
								y--;
								Kart1[y][x] = '^';

							}
							break;
						case '^':

							Kart1[y][x] = ' ';
							y--;


							if (Kart1[y][x] != '#' && Kart1[y][x] != '@')
							{
								Kart1[y][x] = '^';


							}
							else if (Kart1[y][x] == '@')
							{

								Kart1[y][x] = '^';
								comp_a -= 30;


							}

							if (Kart1[y][x] != '#' && Kart1[y][x] != '&')
							{
								Kart1[y][x] = '^';


							}
							else if (Kart1[y][x] == '&')
							{

								Kart1[y][x] = '^';
								


							}
							if (Kart1[y][x] != '#' && Kart1[y][x] != '$')
							{
								


							}
							else if (Kart1[y][x] == '$')
							{

								Kart1[y][x] = '^';
								comp_a -= 10;


							}
							
							break;
						case '@':
						
							randnull_a = rand() % 2 + 1;

							if (randnull_a == 1)
							{
								Kart1[y][x] = ' ';
								y++;
								Kart1[y][x] = '@';
								
								y++;
								Kart1[y][x] = '*';
								y++;
								
							}
							 if (Kart1[y][x] == '#')
							{
								 your_a -= 200;
							}
							 break;
						case '&':

							randnull_a = rand() % 4 + 1;

							if (randnull_a == 1)
							{
								Kart1[y][x] = ' ';
								y++;
								Kart1[y][x] = '&';

								y++;
								Kart1[y][x] = '*';
								y++;

							}
							if (Kart1[y][x] == '#')
							{
								your_a -= 200;
							}


							
							break;

						case '$':

							randnull_a = rand() % 5 + 1;

							if (randnull_a == 1)
							{
								Kart1[y][x] = ' ';
								y++;
								Kart1[y][x] = '$';

								y++;
								Kart1[y][x] = '*';
								y++;

							}
							if (Kart1[y][x] == '#')
							{
								your_a -= 200;
							}
							break;

						case '*':
							Kart1[y][x] = ' ';
							y++;

							if (Kart1[y][x] != '#' && Kart1[y][x] != 'W')
							{
								Kart1[y][x] = '*';

							}
							else if (Kart1[y][x] == 'W')
							{
								your_a -= 20;



							}
							break;
						
						}
						

					}
					
					if (comp_a == 0)
					{
						system("cls");
						std::cout << "\tYou played!!!" << std::endl;
						system("pause");
						return 0;
					}
					if (your_a <= 0)
					{
						system("cls");
						std::cout << "\tSory Ho Ho Ho!!!" << std::endl;
						system("pause");
						return 0;
					}
				}
				
				
				


			}
			
			


		Sleep(gamespeed);
		Sleep (gamespeed_a); 
	}
	
	system("cls");
	std::cout << "\tYou last!!!" << std::endl;
	system("pause");
	return 0;
}