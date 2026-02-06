cmake_minimum_required(VERSION 4.1)
project(test)

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED True)
set(CMAKE_CXX_COMPILER clang++)


add_compile_options(-std=c++17)
add_compile_options(-fpermissive)
add_compile_options(-Werror=attributes)
add_compile_options(-Wall)
add_compile_options(-Wunused)
add_compile_options(-Wunused-parameter)
add_compile_options(-Wreturn-type)
add_compile_options(-Wunknown-pragmas)

add_executable(test
main.cpp
)
