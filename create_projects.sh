#!/usr/bin/env bash

ARGC=$#
if [ $ARGC -ne 2 ]; then
  echo "Usage: ./create_projects.sh [CHAPTER] [TASK_COUNT]"
  exit 1
fi

chapter="$1"
taskCount="$2"

for ((i=1; i<=taskCount; i++)); do
    padded_i=$(printf "%02d" $i) 
    dotnet new console -n Ch$chapter-$padded_i -o Chapter$chapter/Ch$chapter-$padded_i
    dotnet sln add ./Chapter$chapter/Ch$chapter-$padded_i/Ch$chapter-$padded_i.csproj

    file="./Chapter$chapter/Ch$chapter-$padded_i/Program.cs"
    cat >$file <<-EOF
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
EOF
done
