toList :: Integer -> [Int]
toList = map (read . return) . show

reverseList  [] = []
reverseList  xs = last xs : reverseList (init xs)

main = do
    inputNumberRead <- getLine 
    rotationTimesRead <- getLine
    let rotationTimes = read(rotationTimesRead) :: Integer
    let inputNumber = read(inputNumberRead) :: Integer
    --if inputNumber == 0 
    if odd inputNumber then
        print(reverseList (toList inputNumber))
    else print(toList inputNumber)
    
    