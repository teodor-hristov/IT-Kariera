doubleMe :: Int -> Int
doubleMe x = 2*x

sayNumber :: Int -> String
sayNumber n = if n == 42 then "K brat" else "ne e k brat"

myMax :: Int -> Int -> Int -> Int
myMax a b c = if a >= b && a >= c then a 
                                  else if b >= c then b
                                  else c

day :: Int-> [Char]
day x = case x of
                1 -> "M"
                2 -> "T"
                3 -> "W"
                4 -> "T" 
                5 -> "F"
                6 -> "S"
                7 -> "S"
                _ -> day(mod x 7)

mySchool :: String -> Bool
mySchool "UKTC" = True
mySchool "GPCHE" = False

signumMy :: Int -> Int
signumMy x
    | x > 0 = 1
    | x == 0 = 0
    | x < 0 = -1

fact :: Int -> Int
fact n
    | n == 0 = 1
    | n > 0 = n * fact (n-1)

fibonacci :: Int -> Int
fibonacci n 
    | n == 1 || n == 2 = 1
    | n > 2 = fibonacci(n-2) + fibonacci(n - 1)

func1 :: Float -> Float
func1 x
    | x > 2 = x*x - x - 4
    | x >= 1 && x <= 2 = x + 7
    | x < 1 = 0

celi4isla :: Int -> Int -> Int -> String
celi4isla m n x
    | x == m           = "Left"
    | x == n           = "Right"
    | x < m            = "Far left"
    | x > n            = "Far right"
    | x >= m && x <= n = "MID"

func2 :: Int -> Int -> Bool
func2 a b = 
    if a == 0 then False
    else if b /= mod a 10 then func2 (div a 10) b
    else True

trarea :: Float -> Float -> Float -> Float
trarea a b c = sqrt(p*(p - a)*(p - b)*(p - c))
    where p = (a+b+c)/2

fastpower :: Int -> Int -> Int
fastpower base power
    |power == 0 = 1
    |odd power = (fastpower base (div power 2)) ^ 2 * base
    |even power = (fastpower base (div power 2)) ^ 2

