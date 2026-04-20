# Contributing to csharp-design-patterns

Thank you for your interest in improving this project! This guide will help you contribute effectively.

---

## 📍 Repository

**Location**: [csharp-design-patterns](https://github.com/MarioCodes/csharp-design-patterns)

---

## 🎯 Ways to Contribute

### 1. Report Issues

Found a problem? Open an [issue](https://github.com/MarioCodes/csharp-design-patterns/issues).

**Good issue titles**:
- ✅ `Strategy pattern example doesn't compile on .NET 8`
- ✅ `Missing unit tests for Observer pattern`
- ❌ `Code doesn't work` (too vague)

**Include**:
- .NET SDK version (`dotnet --version`)
- Operating system
- Exact error message or unexpected behavior
- Steps to reproduce

### 2. Suggest Improvements

Have an idea? Open an issue with:
- **Problem**: What's missing or could be better
- **Proposed solution**: Specific improvement
- **Use case**: Why this helps other developers

### 3. Add a New Design Pattern

Want to contribute a pattern that's not yet covered?

**Requirements**:
- **Correct**: Follows the pattern's intent as described in GoF or other recognized references
- **Practical**: Includes a real-world use case, not just a textbook example
- **Tested**: Includes unit tests that validate the pattern's behavior
- **Documented**: Clear README explaining when and why to use the pattern

**Structure** (follow the existing project conventions):
```
PatternName/
    ├── README.md              # Explanation, UML diagram, when to use
    └── Project                # Core implementation 
```

### 4. Improve Existing Patterns

Improvements to existing implementations are very welcome:
- Add missing unit tests
- Improve code readability or documentation
- Add alternative implementations (e.g., using modern C# features like records, pattern matching, etc.)
- Fix bugs or compilation issues

### 5. Fix Documentation Errors

Found a typo, broken link, or outdated information? Submit a PR.

**Small fixes** (typos, links): Direct PR welcome.
**Large changes** (restructure, new sections): Open an issue first to discuss.

---

## 🔄 Pull Request Process

1. **Fork** the repository and create a branch from `master`
2. **Follow** the existing project structure and conventions
3. **Commit** with clear messages (e.g., `Add Builder pattern`)
4. **Open a PR** against `master`

**PR Checklist** (add this to your PR description):
```markdown
- [ ] Code compiles without warnings (dotnet build)
- [ ] Follows existing project structure
- [ ] Includes or updates README for the pattern
- [ ] No broken links
```

---

## ❓ Questions?

- **Documentation questions**: Open an issue with the `question` label
- **General discussion**: Open a [Discussion](https://github.com/MarioCodes/csharp-design-patterns/discussions)

---

## 📄 License

By contributing, you agree that your contributions will be licensed under the same license as the project.

---

## 🙏 Recognition

Contributors are recognized in:
- Repository contributors graph
- CHANGELOG.md (for significant contributions)

---

*Thank you for helping make this project better!*
