This solution demonstrates that MsBuild 17 can not build .net Framework 4.8 
projects which reqire a licenses.licx file.

We want to migrate some of our projects to dotnet 6 or 7, but still need to be 
able to build old Framework 4.8 projects together in the same solution. 
Moving those projects into separate solutions is not an option for us since there
is shared code between those projects and we would lose immediate compiler feedback if 
we broke something in the other solution.

Is there a way in rider to specify msbuild versions per project instead of per solution,
or do you have any other idea on how to solve this?