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

sort3 :: (Int, Int, Int) -> (Int, Int, Int)
sort3 (a, b, c)
                | a >= b && a >= c && b >= c = (a,b,c)
                | a >= b && a >= c && c >= b = (a,c,b)
                | b >= a && b >= c && a >= c = (b,a,c)
                | b >= a && b >= c && c >= a = (b,c,a)
                | c >= a && c >= b && a >= b = (c,a,b)
                | c >= a && c >= b && b >= a = (c,b,a)

revWords :: String -> String
revWords input = (unwords.reverse.words) input

sumList :: [Int] -> Int
sumList [] = 0
sumList (x:xs) = x + sumList xs

concatList :: [[a]] -> [a]
concatList [] = []
concatList (x:xs) = x ++ concatList xs

findMember :: Int -> [Int] -> Bool
findMember num [] = False
findMember x (y:ys) = (x == y) || (findMember x ys)

plus1 :: [Int] -> [Int]
plus1 [] = []
plus1 (x:xs) = x + 1 : plus1 xs

plusn :: Int -> [Int] -> [Int]
plusn n [] = []
plusn n (x:xs) = x + n : plusn n xs

make :: (Int -> Int) -> [Int] -> [Int]
make func [] = []
make func (x:xs) = (func x) : make func xs