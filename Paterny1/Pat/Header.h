#pragma once
#include <iostream>

class Reminder {
public:
	virtual ~Reminder() {
	}
	virtual void EnterTask() const = 0;
};

class SimpleCommand : public Reminder {
private:
	std::string pay_load_;
	std::string Task, Task2, Task3;


public:
	explicit SimpleCommand(std::string pay_load, std::string Task, std::string Task2, std::string Task3)
		: pay_load_(pay_load), Task(Task), Task2(Task2), Task3(Task3) {
	}
	void  EnterTask() const override {
		std::cout << "\n We will plan events for the next month! (" << this->pay_load_ << ")\n";
		std::cout << "\n Task 1: (" << this->Task << ")\n";
		std::cout << "\n Task 2: (" << this->Task2 << ")\n";
		std::cout << "\n Task 3: (" << this->Task3 << ")\n";

	}





};


class Receiver {
public:
	void DoSomething(const std::string &a) {
		std::cout << "\n Task 0: (" << a << ")\n";
	}
	void DoSomethingElse(const std::string &b) {
		std::cout << "\n Task 0: (" << b << ")\n";
	}
};


class ComplexCommand : public Reminder {

private:
	Receiver *receiver_;

	std::string a_;
	std::string b_;

public:
	ComplexCommand(Receiver *receiver, std::string a, std::string b) : receiver_(receiver), a_(a), b_(b) {
	}

	void EnterTask() const override {
		this->receiver_->DoSomething(this->a_);
		this->receiver_->DoSomethingElse(this->b_);

	}
};


class Invoker {

private:
	Reminder *on_start_;

	Reminder *on_finish_;

public:
	~Invoker() {
		delete on_start_;
		delete on_finish_;
	}

	void SetOnStart(Reminder *reminder) {
		this->on_start_ = reminder;
	}
	void SetOnFinish(Reminder *reminder) {
		this->on_finish_ = reminder;
	}

	void DoSomethingImportant() {
		std::cout << " Hello!\n";
		if (this->on_start_) {
			this->on_start_->EnterTask();
		}
		std::cout << "\n Completed tasks!\n";
		if (this->on_finish_) {
			this->on_finish_->EnterTask();
		}
	}
};

