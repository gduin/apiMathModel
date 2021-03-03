
# Add two lists using map and lambda 
  
numbers1 = [1, 2, 3, 3, 4] 
numbers2 = [4, 5, 6, 7] 
  
result = map(lambda x, y: x + y, numbers1, numbers2) 
print(list(result), end="") 
