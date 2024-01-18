# CodingDojo

## Dummy Commits (testing my local config)
1. Lorenzo Solano M.
2. Cesar Encarnacion
3. (next person)


## Public API

```
public class PostService{

Atributtes
    BadWordsChecker
    PostRepository
Methods
    PostService(BadWordsChecker bdChecker,PostRepository postRepository)
    int CreatePost(Post post)
}
```

```
public class BadWordsChecker{

Atributtes
    BadWordsGlobalList
Methods
    BadWordsChecker(BadWordsGlobalList bwList)
    List<string> CheckerText(string post)
}
```

```
public class PostRepository{

Atributtes
    APIUrl
Methods
    int SendPost(Post post)
}
```