# Gra w kości
Aplikacja konsolowa napisana w języku C#, implementująca logikę gry w kości sześcienne z oczkami od 1 do 6.

## Działanie programu
Program pobiera od użytkownika liczbę kostek do rzucenia z przedziału od 3 do 10, powtarzając zapytanie do momentu podania poprawnej wartości. Następnie za pomocą metod klasy `GraWKosci` losuje odpowiednią liczbę oczek, zapisuje je w tablicy i wyświetla wynik rzutu każdej kostki w konsoli.

Osobna metoda oblicza i zwraca sumę punktów, zliczając wyłącznie te oczka, które zostały wylosowane co najmniej dwa razy. Po wyświetleniu zdobytych punktów program pyta gracza o chęć ponownego rzutu (`t` – powtórzenie losowania dla tej samej liczby kostek, `n` – zakończenie działania aplikacji).