[![License](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

# MaxConsecutiveOnes (C#)
This repository contains a C# program, MaxConsecutiveOnes, designed to efficiently find the maximum number of consecutive ones in a binary array. The program takes an input array consisting of only 0s and 1s, utilizing an optimized algorithm to determine the length of the longest consecutive subarray of 1s.

## Features
Efficient Algorithm: MaxConsecutiveOnes implements an algorithm that ensures optimal performance in identifying the longest consecutive sequence of ones in a binary array.

Simple Integration: The program is designed for easy integration into your C# projects. Simply clone the repository, adjust the input array, and obtain the desired result.

## Usage

To use MaxConsecutiveOnes in your C# project, follow these steps:

1. Clone the repository to your local machine:

   ```bash
   git clone https://github.com/Sam-Rex/MaxConsecutiveOnes.git

2. Open the solution in your preferred C# development environment (e.g., Visual Studio).

3. Locate the MaxConsecutiveOnes.cs file, which contains the main logic for finding the maximum consecutive ones.

4. Modify the input array in the code to match your binary array:
   
   `int[] numbers = {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1};`
5. Build and run the program to get the length of the longest consecutive subarray of 1s.

## Example
```csharp
    ﻿Solution solution = new Solution();
    
    int[] numbers = {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1};
    
    var result = solution.FindMaxConsecutiveOnes(numbers);
    
    Console.WriteLine(result);
```
## Contributing
If you'd like to contribute to MaxConsecutiveOnes, feel free to open an issue or submit a pull request. Contributions are welcome!

## License
This project is licensed under the MIT License - see the LICENSE file for details. 
