# Sieve-Of-Eratosthenes

This is an implementation of the Sieve of Eratosthenes using the ASP.NET MVC framework. This web application requests an input from the user and displays the number of prime numbers from 2 till the number and also the count of the primes.
The main logic can be found in HomeController.cs in the Index action.
Starting with a list of odd numbers till n, the Sieve is implemented reducing the size to n/2.
The implementation considers only removing multiples for a number starting from its square since its multiples before that have already been taken care of in the previous iterations improving the time efficiency.
Important Files – HomeController.cs (Controller)
                                Number.cs  (Model)
                                Index.cshtml (View)
