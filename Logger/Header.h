#pragma once
#include<iostream>
#include<fstream>
#include <string>

#define Debug Logger::init()
#define INFO Debug.info
#define ERROR Debug.error

const std::string file = "Debug";
static size_t counter;

class Logger {

public:
	static Logger& init() {
		static Logger logger;

		return logger;
	};


	void error(std::string msg) {
		std::cout << "LOL, ERROR " + msg;
	}

	void info(std::string msg) {
		std::cout << "INFO: " + msg;
	}

	Logger(const Logger& log) = delete;
	Logger& operator=(const Logger&) = delete;

	~Logger() {
		INFO("File opened " + std::to_string(counter) + " times\n");
		debug_file.close();
	}
private:
	Logger() {
		debug_file.open(file);
		counter++;
	};

	std::ofstream debug_file;

};
