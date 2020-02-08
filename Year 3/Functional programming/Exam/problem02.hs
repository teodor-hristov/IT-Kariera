toList :: Integer -> [Int]
toList = map (read . return) . show

reverseList  [] = []
reverseList  xs = last xs : reverseList (init xs)

main = do
    inputNumber <- readLn
    --rotationTimes <- readLn
    print(reverseList (toList inputNumber))
    