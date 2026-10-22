for i in {1..50}; do
  rm -rf "task$i"
  dotnet new console -o "task$i" --use-program-main false && \
  mv "task$i/Program.cs" "task$i/task$i.cs"
done
