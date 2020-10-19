#pragma once

void Paint()
{

	system("cls");


	for (int i = 0; i < width + 1; i++)
		std::cout << "#";
	std::cout << std::endl;

	for (int i = 0; i < height; i++)
	{
		for (int j = 0; j < width; j++)
		{
			if (j == 0 || j == width - 1)
				std::cout << "#";
			if (i == y && j == x)
				std::cout << "$";
			else if (i == fructY && j == fructX)
				std::cout << "@";
			else
			{
				bool print = false;
				for (int c = 0; c < nArr; c++)
				{
					if (arrX[c] == j && arrY[c] == i)
					{
						print = true;
						std::cout << "o";
					}

				}
				if (!print)
					std::cout << " ";
			}

		}
		std::cout << std::endl;


	}

	for (int i = 0; i < width + 1; i++)
		std::cout << "#";
	std::cout << std::endl;
	std::cout << "Size: " << size << std::endl;







}
