# Multi-Threading & Asynchronous Prosgrammming

# 1. Introduction
- *create* the `Thread`
- *assign* task (aka `Method`) to the Thread
- *run* the thread with `start()`

## 1.1 Splitting Data Equal Chunks
### 1.1.1 Psuedo-Code
1. Split data by **equal** chunk sizes
2. Remainder distributed from first chunks

### 1.1.2 Example: Split Data
| Type   | Value |
|--------|--------|
| Array  | `[1, 2, 3, 4, 5, 6, 7, 8, 9, 10]` |
| Matrix | See below |

```python
[
  [0, 1, 2, 3],
  [4, 5, 6, 7],
  [8, 9, 10]
]
```




