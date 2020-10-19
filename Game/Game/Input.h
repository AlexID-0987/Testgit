#pragma once
void Input()
{
	if (_kbhit())
	{
		switch (_getch())
		{
		case'a':
			dr = LEFT;
			break;
		case'd':
			dr = RIGHT;
			break;
		case'w':
			dr = UP;
			break;
		case's':
			dr = DOWN;
			break;
		case'x':
			gOver = true;
			break;
		}
	}


}

