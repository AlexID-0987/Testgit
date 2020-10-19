#pragma once

void Up()
{
	gOver = false;
	dr = STOP;
	x = width / 2 - 1;
	y = height / 2 - 1;
	fructX = rand() % width;
	fructY = rand() % height;
	size = 0;
}
