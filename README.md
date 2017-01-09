# fsharpTest [![Build Status](https://travis-ci.org/kuroyakov/fsharpTest.svg?branch=master)](https://travis-ci.org/kuroyakov/fsharpTest)
このプロジェクトはF#でライブラリ開発する時にTravis-CI
と連携するための最小限構成を構築したものです。

開発環境構築については[Wiki](https://github.com/kuroyakov/fsharpTest/wiki)を参照ください。
(日本語のみ)

This project is F# Development Environment using Travis-CI.



## This project is for

クラスライブラリを作成する開発者が、
Githubへリポジトリをプッシュして、Travis-CIで自動ビルド-テスト-デプロイ
（タグ付きコミットのみ）できる仕組みを最小限に構築したい場合に役立つと思います。

尚、テストフレームワークはExpectoを利用します。

Developer who will make .NET Class Library 
using test framework(Expecto).
The developer is also expected to use Github and Travis-CI

## Configuration
本プロジェクトは2つのF#プロジェクトで構成されています。

This project has 2 F# projects: testLib and testLibTest

| ProjectName | Description                              |
|-------------|------------------------------------------|
| testLib     |.NET Class Library project                |
| testLibTest |Unit-test project which is used by Expecto|

## LICENSE
MIT