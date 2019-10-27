type Student = (String, Int)
s1 :: Student
s2 :: Student
s1 = ("Qsen ko4ev", 23)
s2 = ("Gosho", 14)

minMax :: Int -> Int -> (Int, Int)
minMax a b = 
    if a >= b then (b, a)
    else (a, b)

sumNum :: (Int, Int) -> Int
sumNum (a, b) = a + b