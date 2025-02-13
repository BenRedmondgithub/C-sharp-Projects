﻿using System.Diagnostics;

var todos = new List<string>();

Console.WriteLine("Hello!");

bool shallExit = false;
while(!shallExit)
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do? ");
    Console.WriteLine("[S]ee all ToDos");
    Console.WriteLine("[A]dd a ToDo");
    Console.WriteLine("[R]emove a ToDo");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "E":
        case "e":
        shallExit = true;
        break;

        case "S":
        case "s": 
        SeeAllTodos();
        break;

        case "A":
        case "a": 
        AddTodo();
        break;

        case "R":
        case "r": 
        RemoveTodo();
        break;

        default: 
        Console.WriteLine("Invalid Choice");
        break;
    }
}

Console.ReadLine();

void SeeAllTodos() 

{

    if ( todos.Count == 0 )
    {
        ShowNoTodosMessage();
        return;
    }

    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i+1}. {todos[i]}");   
    }

}

void AddTodo() 
{
    string description;
    do 
    {
        Console.WriteLine("Enter The ToDo Description");
        description = Console.ReadLine();
    }

    while (!IsDescriptionValid(description));
    todos.Add(description);
}

bool IsDescriptionValid(string description) 
{

    if (description == "") 

    {
    Console.WriteLine("The Description cannot be empty");
    }

    if (todos.Contains(description)) 

    {
    
    Console.WriteLine("The description Must be unique");
    return false;
    
    }
return true;
}

void RemoveTodo() 
{



}

//bool TryReadIndex(out int index)
{



}

void RemoveTodoAtIndex (int index)
{



}

void ShowNoTodosMessage() 
{
    Console.WriteLine("No ToDos have been added yet.");
}