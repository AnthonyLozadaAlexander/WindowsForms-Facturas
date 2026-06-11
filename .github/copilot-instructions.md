# GitHub Copilot Instructions for Commits

When generating commit messages, please follow the [Conventional Commits](https://www.conventionalcommits.org/) specification.

## Format
```
<type>[optional scope]: <description>

[optional body]

[optional footer(s)]
```

## Types
* **feat**: A new feature
* **fix**: A bug fix
* **docs**: Documentation only changes
* **style**: Changes that do not affect the meaning of the code (white-space, formatting, missing semi-colons, etc)
* **refactor**: A code change that neither fixes a bug nor adds a feature
* **perf**: A code change that improves performance
* **test**: Adding missing tests or correcting existing tests
* **build**: Changes that affect the build system or external dependencies
* **ci**: Changes to our CI configuration files and scripts
* **chore**: Other changes that don't modify src or test files
* **revert**: Reverts a previous commit

## Rules
1. The description should be written in imperative mood ("add", not "added" or "adds").
2. No capitalization of the first letter in the description.
3. No dot (.) at the end of the description.
4. Keep the first line under 72 characters.
5. If there is a body, it should be separated from the description by a blank line and provide more details about the changes.
