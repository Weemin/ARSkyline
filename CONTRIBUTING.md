# Contribution Guidelines
## Table of Contents
- [Contribution Guidelines](#contribution-guidelines)
  - [Table of Contents](#table-of-contents)
  - [Introduction](#introduction)
  - [Discuss](#discuss)
  - [Code review](#code-review)
  - [Language](#language)
  - [Style guide](#style-guide)
  - [Unity rules](#unity-rules)
  - [Unity additive scene](#unity-additive-scene)
  - [Building](#building)
  - [Copyright](#copyright)

## Introduction
This document explains how to contribute changes to ARSkyline project.It is strongly advised to read this document before even starting the development of a contribution.
## Discuss
All contributions are welcome, however it is necessary to ensure that all the information described in this document is known and that all the rules are respected.

To propose modifications, it is necessary to create an issue by following the proposed template. During all the interactions on the project, it is important to explain and document all of what is said.
## Code review
All changes made must be verified by other users before being incorporated.

In order to facilitate verification, it is advisable to proceed with small but multiple pull requests and issues.
## Language
All interactions on the project must be done in English.
## Style guide
It is necessary to respect the way C# code and Unity components are organized.
## Unity rules
In order to maintain the integrity of the Unity project, these rules must be respected:
- Do not update unity project version
- Use only open source assets
- Do not add unnecessary assets
- Use additive scene system
Use additive scene system
## Unity additive scene
The unity additive scene system allows you to separate a main scene into many small scenes.
ARSkyline is organized according to this principle which must be respected.
## Building
To build the project, simply launch the Unity project then build according to the desired platform. In order to guarantee compatibility with augmented reality plugins, you must not modify the player settings.
## Copyright
All files must have this header.
```
// Copyright 2022 ARSkyline Authors. All rights reserved.
// Powered by Weemin
```