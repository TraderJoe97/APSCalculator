# APS Calculator

A console-based application to calculate university Admission Point Score (APS) based on subject scores.

## Overview

The APS Calculator helps prospective university students calculate their Admission Point Score, which is used by many South African universities to determine eligibility for admission to various programs. The application takes subject scores as input and converts them to APS points based on standardized scoring criteria.

## Features

- Calculate APS scores based on 6 subjects
- Input validation for subject scores (0-100)
- Detailed breakdown of subjects with scores and corresponding APS points
- User-friendly console interface

## How it Works

The application converts percentage scores to APS points using the following scale:
- 80-100%: 7 points
- 70-79%: 6 points
- 60-69%: 5 points
- 50-59%: 4 points
- 40-49%: 3 points
- 30-39%: 2 points
- 0-29%: 1 point

## Getting Started

### Prerequisites
- .NET SDK (5.0 or later recommended)

### Installation
1. Clone this repository or download the source code
2. Navigate to the project directory in your terminal
3. Run the application:
```
dotnet run
```

## Usage

1. Launch the application
2. Enter the name and score for each of your 6 subjects when prompted
3. The system will validate your inputs and calculate your APS
4. Review the detailed breakdown and your total APS score

## Example

```
Welcome to the Admission Point Score Calculator!

Enter details for Subject 1:
Subject Name: Mathematics
Subject Score (0-100): 85

Enter details for Subject 2:
Subject Name: English
Subject Score (0-100): 75

...

--------------------
Subject Breakdown:
Mathematics: Score = 85, Points = 7
English: Score = 75, Points = 6
...
--------------------
Your total Admission Point Score (APS) is: 32
```

## Developers

This project was developed by:
- Joseph Monakedi
- Dumisani Nxumalo

## License

This project is open source and available under the [MIT License](LICENSE).

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.
