#pragma once

void Log()
{
	int prevX = arrX[0];
	int prevY = arrY[0];
	int prev2X, prev2Y;
	arrX[0] = x;
	arrY[0] = y;
	for (int i = 1; i < nArr; i++)
	{
		prev2X = arrX[i];
		prev2Y = arrY[i];
		arrX[i] = prevX;
		arrY[i] = prevY;
		prevX = prev2X;
		prevY = prev2Y;

	}
	switch (dr)

	{
	case LEFT:
		x--;
		break;
	case RIGHT:
		x++;
		break;
	case UP:
		y--;
		break;
	case DOWN:
		y++;
		break;
	}




	if (x >= width - 1)
		x = 0;
	else if (x < 0)
		x = width - 2;
	if (y >= height - 1)
		y = 0;
	else if (y < 0)
		y = height - 2;


	for (int i = 0; i < nArr; i++)
	{
		if (arrX[i] == x && arrY[i] == y)
			gOver = true;
	}



	if (x == fructX && y == fructY)
	{
		size += 20;
		fructX = rand() % width;
		fructY = rand() % height;
		nArr++;
	}


}

