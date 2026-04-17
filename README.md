# Unity Input Field Deletion Bug

## 🐛 Description
This project reproduces a UI bug in Unity where text inside an input field cannot be deleted normally.

## 🎮 Bug Behavior
- User types text into the input field
- Backspace/Delete does not remove text
- User must select all text (Ctrl + A) to delete it

## 🔁 Steps to Reproduce
1. Open the project in Unity
2. Open the main scene
3. Click on the input field
4. Type any text
5. Try deleting with Backspace

## ❌ Actual Result
Text is not deleted unless all content is selected first.

## ✅ Expected Result
Text should be deletable character-by-character.

## 🛠️ Possible Cause
- Input handling conflict
- Focus state issue in UI system
- Event system misconfiguration

## 💡 What I Learned
- Unity UI system
- Input handling
- Debugging UI bugs

- ## 📌 Purpose
This project was created to practice bug reproduction and debugging in a real-world scenario.
