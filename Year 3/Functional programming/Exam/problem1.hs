sumNumber :: Int -> Int
sumNumber 0 = 0
sumNumber n = (mod n 10) + sumNumber(div n 10)

main = do
    num <- readLn
    print(sumNumber num)